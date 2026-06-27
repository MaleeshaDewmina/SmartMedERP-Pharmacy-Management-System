using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SmartMedERP.Repositories;

namespace SmartMed.Forms
{
    /*
     * Displays invoice details for a selected order.
     * This form supports invoice viewing, PDF export and print preview.
     */
    public partial class InvoiceForm : Form
    {
        private readonly InvoiceRepository invoiceRepository =
            new InvoiceRepository();

        private int currentOrderId = 0;

        private DataTable invoiceHeaderTable =
            new DataTable();

        private DataTable invoiceItemsTable =
            new DataTable();

        public InvoiceForm()
        {
            InitializeComponent();
        }

        public InvoiceForm(int orderId)
        {
            InitializeComponent();

            currentOrderId = orderId;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        // Loads invoice header and item details for the selected order.
        private void LoadInvoice()
        {
            if (currentOrderId == 0)
            {
                MessageBox.Show("No order selected.");
                this.Close();
                return;
            }

            invoiceHeaderTable =
                invoiceRepository.GetInvoiceHeader(currentOrderId);

            invoiceItemsTable =
                invoiceRepository.GetInvoiceItems(currentOrderId);

            if (invoiceHeaderTable.Rows.Count == 0)
            {
                MessageBox.Show("Invoice data not found.");
                this.Close();
                return;
            }

            LoadHeaderDetails();
            LoadItems();
        }

        // Displays invoice customer, payment, prescription and total details.
        private void LoadHeaderDetails()
        {
            DataRow row =
                invoiceHeaderTable.Rows[0];

            lblInvoiceDate.Text =
                "Date: " + GetDate(row, "OrderDate").ToString("yyyy-MM-dd hh:mm tt");

            lblOrderId.Text =
                "Order ID: #" + GetString(row, "OrderId");

            lblCustomerName.Text =
                "Customer: " + GetString(row, "CustomerName");

            string phone =
                GetString(row, "DeliveryPhone");

            if (string.IsNullOrWhiteSpace(phone))
                phone = GetString(row, "CustomerPhone");

            lblDeliveryPhone.Text =
                "Phone: " + phone;

            lblDeliveryAddress.Text =
                "Address: " + GetString(row, "DeliveryAddress");

            lblOrderStatus.Text =
                "Status: " + GetString(row, "Status");

            lblPaymentMethod.Text =
                "Payment: " + GetString(row, "PaymentMethod");

            lblPaymentStatus.Text =
                "Payment Status: " + GetString(row, "PaymentStatus");

            string prescriptionRequired =
                GetString(row, "PrescriptionRequired") == "True"
                ? "Required"
                : "Not Required";

            lblPrescriptionStatus.Text =
                "Prescription: " +
                prescriptionRequired +
                " / " +
                GetString(row, "PrescriptionStatus");

            lblSubTotal.Text =
                "Sub Total: Rs. " + GetDecimal(row, "SubTotal").ToString("N2");

            lblDiscount.Text =
                "Discount: Rs. " + GetDecimal(row, "DiscountAmount").ToString("N2");

            decimal tax =
                GetDecimal(row, "TaxAmount");

            decimal deliveryFee =
                GetDecimal(row, "DeliveryFee");

            lblTax.Text =
                "Tax + Delivery: Rs. " + (tax + deliveryFee).ToString("N2");

            lblGrandTotal.Text =
                "Grand Total: Rs. " + GetDecimal(row, "GrandTotal").ToString("N2");
        }

        // Loads medicine line items into the invoice grid.
        private void LoadItems()
        {
            dgvInvoiceItems.DataSource =
                invoiceItemsTable;

            FormatItemsGrid();
        }

        // Formats the invoice item grid for display.
        private void FormatItemsGrid()
        {
            if (dgvInvoiceItems.Columns.Count == 0)
                return;

            if (dgvInvoiceItems.Columns.Contains("MedicineName"))
                dgvInvoiceItems.Columns["MedicineName"].HeaderText = "Medicine";

            if (dgvInvoiceItems.Columns.Contains("UnitPrice"))
                dgvInvoiceItems.Columns["UnitPrice"].HeaderText = "Unit Price";

            dgvInvoiceItems.ReadOnly = true;
            dgvInvoiceItems.AllowUserToAddRows = false;
            dgvInvoiceItems.AllowUserToDeleteRows = false;
            dgvInvoiceItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvInvoiceItems.MultiSelect = false;
            dgvInvoiceItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceItems.RowHeadersVisible = false;
        }

        // Safely reads a string value from a DataRow.
        private string GetString(DataRow row, string columnName)
        {
            if (row == null)
                return "";

            if (!row.Table.Columns.Contains(columnName))
                return "";

            if (row[columnName] == null ||
                row[columnName] == DBNull.Value)
                return "";

            return row[columnName].ToString();
        }

        // Safely reads a decimal value from a DataRow.
        private decimal GetDecimal(DataRow row, string columnName)
        {
            string value =
                GetString(row, columnName);

            if (decimal.TryParse(value, out decimal result))
                return result;

            return 0;
        }

        // Safely reads a date value from a DataRow.
        private DateTime GetDate(DataRow row, string columnName)
        {
            string value =
                GetString(row, columnName);

            if (DateTime.TryParse(value, out DateTime result))
                return result;

            return DateTime.Now;
        }

        // Allows the user to export the invoice as a PDF file.
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (invoiceHeaderTable.Rows.Count == 0)
            {
                MessageBox.Show("No invoice data to export.");
                return;
            }

            SaveFileDialog saveFileDialog =
                new SaveFileDialog();

            saveFileDialog.Title = "Save Invoice PDF";
            saveFileDialog.Filter = "PDF File|*.pdf";
            saveFileDialog.FileName =
                "SmartMed_Invoice_" + currentOrderId + ".pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ExportInvoicePdf(saveFileDialog.FileName);

                MessageBox.Show("Invoice PDF exported successfully.");

                Process.Start(saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF export failed: " + ex.Message);
            }
        }

        // Generates the invoice PDF using iTextSharp.
        private void ExportInvoicePdf(string filePath)
        {
            DataRow row =
                invoiceHeaderTable.Rows[0];

            Document document =
                new Document(PageSize.A4, 36, 36, 36, 36);

            PdfWriter.GetInstance(
                document,
                new FileStream(filePath, FileMode.Create));

            document.Open();

            AddLogoToPdf(document);

            Font titleFont =
                FontFactory.GetFont(
                    FontFactory.HELVETICA_BOLD,
                    18);

            Font normalFont =
                FontFactory.GetFont(
                    FontFactory.HELVETICA,
                    10);

            Font boldFont =
                FontFactory.GetFont(
                    FontFactory.HELVETICA_BOLD,
                    10);

            Paragraph title =
                new Paragraph("SmartMed Invoice / Receipt", titleFont);

            title.Alignment =
                Element.ALIGN_CENTER;

            document.Add(title);

            document.Add(
                new Paragraph(
                    "Generated Date: " +
                    DateTime.Now.ToString("yyyy-MM-dd hh:mm tt"),
                    normalFont));

            document.Add(new Paragraph(" "));

            // Invoice information table.
            PdfPTable infoTable =
                new PdfPTable(2);

            infoTable.WidthPercentage = 100;

            infoTable.AddCell(CreatePdfCell(
                "Order ID: #" + GetString(row, "OrderId"),
                boldFont));

            infoTable.AddCell(CreatePdfCell(
                "Order Date: " +
                GetDate(row, "OrderDate").ToString("yyyy-MM-dd hh:mm tt"),
                normalFont));

            infoTable.AddCell(CreatePdfCell(
                "Customer: " + GetString(row, "CustomerName"),
                normalFont));

            infoTable.AddCell(CreatePdfCell(
                "Status: " + GetString(row, "Status"),
                boldFont));

            infoTable.AddCell(CreatePdfCell(
                "Phone: " + GetString(row, "DeliveryPhone"),
                normalFont));

            infoTable.AddCell(CreatePdfCell(
                "Payment: " + GetString(row, "PaymentMethod"),
                normalFont));

            infoTable.AddCell(CreatePdfCell(
                "Address: " + GetString(row, "DeliveryAddress"),
                normalFont));

            infoTable.AddCell(CreatePdfCell(
                "Prescription: " +
                GetString(row, "PrescriptionStatus"),
                normalFont));

            document.Add(infoTable);

            document.Add(new Paragraph(" "));

            // Medicine item table.
            PdfPTable itemTable =
                new PdfPTable(5);

            itemTable.WidthPercentage = 100;
            itemTable.SetWidths(new float[] { 3f, 1f, 1.5f, 1.5f, 1.5f });

            AddHeaderCell(itemTable, "Medicine", boldFont);
            AddHeaderCell(itemTable, "Qty", boldFont);
            AddHeaderCell(itemTable, "Unit Price", boldFont);
            AddHeaderCell(itemTable, "Discount", boldFont);
            AddHeaderCell(itemTable, "Total", boldFont);

            foreach (DataRow itemRow in invoiceItemsTable.Rows)
            {
                itemTable.AddCell(CreateBorderCell(
                    GetString(itemRow, "MedicineName"),
                    normalFont));

                itemTable.AddCell(CreateBorderCell(
                    GetString(itemRow, "Quantity"),
                    normalFont));

                itemTable.AddCell(CreateBorderCell(
                    "Rs. " + GetDecimal(itemRow, "UnitPrice").ToString("N2"),
                    normalFont));

                itemTable.AddCell(CreateBorderCell(
                    "Rs. " + GetDecimal(itemRow, "Discount").ToString("N2"),
                    normalFont));

                itemTable.AddCell(CreateBorderCell(
                    "Rs. " + GetDecimal(itemRow, "Total").ToString("N2"),
                    normalFont));
            }

            document.Add(itemTable);

            document.Add(new Paragraph(" "));

            // Total calculation section.
            PdfPTable totalTable =
                new PdfPTable(2);

            totalTable.WidthPercentage = 45;
            totalTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            totalTable.AddCell(CreatePdfCell("Sub Total", normalFont));
            totalTable.AddCell(CreatePdfCell(
                "Rs. " + GetDecimal(row, "SubTotal").ToString("N2"),
                normalFont));

            totalTable.AddCell(CreatePdfCell("Discount", normalFont));
            totalTable.AddCell(CreatePdfCell(
                "Rs. " + GetDecimal(row, "DiscountAmount").ToString("N2"),
                normalFont));

            totalTable.AddCell(CreatePdfCell("Tax", normalFont));
            totalTable.AddCell(CreatePdfCell(
                "Rs. " + GetDecimal(row, "TaxAmount").ToString("N2"),
                normalFont));

            totalTable.AddCell(CreatePdfCell("Delivery Fee", normalFont));
            totalTable.AddCell(CreatePdfCell(
                "Rs. " + GetDecimal(row, "DeliveryFee").ToString("N2"),
                normalFont));

            totalTable.AddCell(CreatePdfCell("Grand Total", boldFont));
            totalTable.AddCell(CreatePdfCell(
                "Rs. " + GetDecimal(row, "GrandTotal").ToString("N2"),
                boldFont));

            document.Add(totalTable);

            document.Add(new Paragraph(" "));

            Paragraph footer =
                new Paragraph(
                    "Thank you for choosing SmartMed Pharmacy.",
                    normalFont);

            footer.Alignment =
                Element.ALIGN_CENTER;

            document.Add(footer);

            document.Close();
        }

        // Adds the form logo image into the exported PDF.
        private void AddLogoToPdf(Document document)
        {
            if (picLogo.Image == null)
                return;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                picLogo.Image.Save(
                    memoryStream,
                    System.Drawing.Imaging.ImageFormat.Png);

                iTextSharp.text.Image logo =
                    iTextSharp.text.Image.GetInstance(
                        memoryStream.ToArray());

                logo.ScaleToFit(140f, 60f);
                logo.Alignment = Element.ALIGN_LEFT;

                document.Add(logo);
            }
        }

        // Creates a PDF cell without border.
        private PdfPCell CreatePdfCell(string text, Font font)
        {
            PdfPCell cell =
                new PdfPCell(new Phrase(text, font));

            cell.Border =
                Rectangle.NO_BORDER;

            cell.Padding = 5;

            return cell;
        }

        // Creates a PDF table cell with default border.
        private PdfPCell CreateBorderCell(string text, Font font)
        {
            PdfPCell cell =
                new PdfPCell(new Phrase(text, font));

            cell.Padding = 5;

            return cell;
        }

        // Adds a styled header cell to a PDF table.
        private void AddHeaderCell(
            PdfPTable table,
            string text,
            Font font)
        {
            PdfPCell cell =
                new PdfPCell(new Phrase(text, font));

            cell.Padding = 6;
            cell.BackgroundColor =
                new BaseColor(230, 230, 230);

            table.AddCell(cell);
        }

        // Opens print preview for the invoice.
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (invoiceHeaderTable.Rows.Count == 0)
            {
                MessageBox.Show("No invoice data to print.");
                return;
            }

            PrintDocument printDocument =
                new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog previewDialog =
                new PrintPreviewDialog();

            previewDialog.Document = printDocument;
            previewDialog.Width = 900;
            previewDialog.Height = 700;

            previewDialog.ShowDialog();
        }

        // Draws invoice content onto the print page.
        private void PrintDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            DataRow row =
                invoiceHeaderTable.Rows[0];

            float x = 50;
            float y = 40;

            System.Drawing.Font titleFont =
                new System.Drawing.Font(
                    "Segoe UI",
                    16,
                    System.Drawing.FontStyle.Bold);

            System.Drawing.Font normalFont =
                new System.Drawing.Font(
                    "Segoe UI",
                    10,
                    System.Drawing.FontStyle.Regular);

            System.Drawing.Font boldFont =
                new System.Drawing.Font(
                    "Segoe UI",
                    10,
                    System.Drawing.FontStyle.Bold);

            e.Graphics.DrawString(
                "SmartMed Invoice / Receipt",
                titleFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 45;

            e.Graphics.DrawString(
                "Order ID: #" + GetString(row, "OrderId"),
                boldFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 25;

            e.Graphics.DrawString(
                "Customer: " + GetString(row, "CustomerName"),
                normalFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 25;

            e.Graphics.DrawString(
                "Phone: " + GetString(row, "DeliveryPhone"),
                normalFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 25;

            e.Graphics.DrawString(
                "Address: " + GetString(row, "DeliveryAddress"),
                normalFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 35;

            e.Graphics.DrawString(
                "Items",
                boldFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            y += 25;

            foreach (DataRow itemRow in invoiceItemsTable.Rows)
            {
                string itemLine =
                    GetString(itemRow, "MedicineName") +
                    " | Qty: " +
                    GetString(itemRow, "Quantity") +
                    " | Total: Rs. " +
                    GetDecimal(itemRow, "Total").ToString("N2");

                e.Graphics.DrawString(
                    itemLine,
                    normalFont,
                    System.Drawing.Brushes.Black,
                    x,
                    y);

                y += 25;
            }

            y += 20;

            e.Graphics.DrawString(
                "Grand Total: Rs. " +
                GetDecimal(row, "GrandTotal").ToString("N2"),
                boldFont,
                System.Drawing.Brushes.Black,
                x,
                y);

            e.HasMorePages = false;
        }

        // Reloads latest invoice data.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}