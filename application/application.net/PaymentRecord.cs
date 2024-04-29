    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace application.net
    {
        public class PaymentRecord
        {
            public int Employee_ID { get; set; }
            [ForeignKey("Employee")]
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public DateTime DOB { get; set; }
            public string Email { get; set; }

            public string Mobile { get; set; }
                [MaxLength(10)]
            public string Department { get; set; }
            public string Designation { get; set; }
            public string Payment_Method { get; set; }
            public string PayMonth { get; set; }
                [ForeignKey("TaxYear")]
            public int TaxCode { get; set; }

        }
    }
