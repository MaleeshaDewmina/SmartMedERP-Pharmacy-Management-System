using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SmartMed.Forms
{
    /*
     * Generates pharmacy reports for admin users.
     * Supported reports include sales, inventory, low stock and expiry reports.
     * Reports can also be exported as PDF files.
     */
    public partial class ReportsForm : Form
    {
        private readonly ReportRepository reportRepository =
            new ReportRepository();

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Clear();

            cmbReportType.Items.Add("Sales Report");
            cmbReportType.Items.Add("Inventory Report");
            cmbReportType.Items.Add("Low Stock Report");
            cmbReportType.Items.Add("Expiry Report");

            cmbReportType.SelectedIndex = 0;

            lblTotalSales.Text = "Rs. 0.00";
            lblTotalOrders.Text = "0";
            lblTotalRevenue.Text = "Rs. 0.00";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        // Generates the selected report and displays it in the grid.
        private void GenerateReport()
        {
            string reportType =
                cmbReportType.Text;

            DataTable reportData =
                new DataTable();

            if (reportType == "Sales Report")
            {
                reportData =
                    reportRepository.GetSalesReport(
                        dtpFromDate.Value,
                        dtpToDate.Value);

                // Sales summary is shown only for the sales report.
                ReportSummary summary =
                    reportRepository.GetSalesSummary(
                        dtpFromDate.Value,
                        dtpToDate.Value);

                lblTotalSales.Text =
                    "Rs. " + summary.TotalSales.ToString("N2");

                lblTotalOrders.Text =
                    summary.TotalOrders.ToString();

                lblTotalRevenue.Text =
                    "Rs. " + summary.TotalRevenue.ToString("N2");
            }
            else if (reportType == "Inventory Report")
            {
                reportData =
                    reportRepository.GetInventoryReport();

                ClearSummary();
            }
            else if (reportType == "Low Stock Report")
            {
                reportData =
                    reportRepository.GetLowStockReport();

                ClearSummary();
            }
            else if (reportType == "Expiry Report")
            {
                reportData =
                    reportRepository.GetExpiryReport();

                ClearSummary();
            }

            dgvReports.DataSource = reportData;
        }

        // Clears sales summary labels when the selected report is not sales-based.
        private void ClearSummary()
        {
            lblTotalSales.Text = "N/A";
            lblTotalOrders.Text = "N/A";
            lblTotalRevenue.Text = "N/A";
        }

        // Allows the generated report to be exported as a PDF file.
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("Please generate a report first.");
                return;
            }

            SaveFileDialog saveFileDialog =
                new SaveFileDialog();

            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save Report as PDF";
            saveFileDialog.FileName =
                cmbReportType.Text.Replace(" ", "_") + ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPdf(
                    dgvReports,
                    saveFileDialog.FileName,
                    cmbReportType.Text);

                MessageBox.Show("PDF exported successfully.");
            }
        }

        // Converts the report grid data into a PDF document using iTextSharp.
        private void ExportDataGridViewToPdf(
            DataGridView dgv,
            string filePath,
            string reportTitle)
        {
            Document document =
                new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);

            PdfWriter.GetInstance(
                document,
                new FileStream(filePath, FileMode.Create));

            document.Open();

            Paragraph title =
                new Paragraph(
                    "SmartMed ERP - " + reportTitle,
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        16));

            title.Alignment =
                Element.ALIGN_CENTER;

            document.Add(title);

            document.Add(
                new Paragraph(
                    "Generated Date: " +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm")));

            document.Add(
                new Paragraph(" "));

            PdfPTable table =
                new PdfPTable(dgv.Columns.Count);

            table.WidthPercentage = 100;

            // Add DataGridView column headers to the PDF table.
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell =
                    new PdfPCell(
                        new Phrase(
                            column.HeaderText,
                            FontFactory.GetFont(
                                FontFactory.HELVETICA_BOLD,
                                9)));

                table.AddCell(cell);
            }

            // Add report row values to the PDF table.
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell gridCell in row.Cells)
                    {
                        string value =
                            gridCell.Value == null
                            ? ""
                            : gridCell.Value.ToString();

                        table.AddCell(
                            new Phrase(
                                value,
                                FontFactory.GetFont(
                                    FontFactory.HELVETICA,
                                    8)));
                    }
                }
            }

            document.Add(table);

            document.Close();
        }
    }
}