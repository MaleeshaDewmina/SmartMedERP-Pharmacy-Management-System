using System;
using SmartMedERP.Repositories;

namespace SmartMedERP.Services
{
    /*
     * Handles audit log business logic.
     * This service records important user actions such as login,
     * logout, order updates, prescription verification and payment updates.
     */
    public class AuditLogService
    {
        private readonly AuditLogRepository auditLogRepository =
            new AuditLogRepository();

        // Creates an audit log entry for the current user action.
        public void Log(
            string actionName,
            string moduleName,
            string description)
        {
            try
            {
                int? userId = null;
                string username = "";
                string roleName = "";

                // Include logged-in user details when a user session is available.
                if (SessionManager.CurrentUser != null)
                {
                    userId =
                        SessionManager.CurrentUser.UserId;

                    username =
                        SessionManager.CurrentUser.Username;

                    roleName =
                        SessionManager.CurrentUser.RoleName;
                }

                // Store the computer name to improve traceability.
                string machineName =
                    Environment.MachineName;

                auditLogRepository.AddLog(
                    userId,
                    username,
                    roleName,
                    actionName,
                    moduleName,
                    description,
                    machineName);
            }
            catch
            {
                /*
                 * Audit logging should never stop the main system process.
                 * If logging fails, the user action should still continue.
                 */
            }
        }
    }
}