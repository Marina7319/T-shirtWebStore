using Microsoft.AspNetCore.Components.Web;
using System.Transactions;

namespace T_shirtStore.Utility
{
    public static class StaticDetails
    {

        public const string roleCustomer = "Customer";

        public const string roleCompany = "Company";

        public const string roleAdmin = "Admin";

        public const string roleEmployee = "Employee";

        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayedPayment = "ApprovedForDelayedPayment";
        public const string PaymentStatusRejected = "Rejected";


        public const string SessionCart = "SessionShoppingCart";

    }
}