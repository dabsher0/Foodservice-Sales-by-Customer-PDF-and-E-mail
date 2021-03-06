﻿using ModernCR;

namespace Foodservice_Sales_by_Customer_PDF_and_E_mail
{
    class Program
    {
        static void Main(string[] args)
        {
            var cr = new RunCrystal();

            //cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Auto-Run.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer.pdf");
            //cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice.pdf");
            cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated.pdf");
            //cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar.pdf");
            cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated.pdf");
            cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated OCA.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated OCA.pdf");
            cr.BuildReport("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated OCA.rpt", "D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated OCA.pdf");

            cr.SetSubject("Profit by Customer");
            cr.SetToAddress("b.harris@teammodern.com");
            cr.SetToAddress("j.shearer@teammodern.com");
            cr.SetToAddress("k.bishop@teammodern.com");
            cr.SetToAddress("j.shackleford@teammodern.com");
            cr.SetToAddress("d.absher@teammodern.com");
            //cr.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer.pdf");
            //cr.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice.pdf");
            cr.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated.pdf");
            //cr.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar.pdf");
            cr.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated.pdf");
            cr.SendEmail();

            //var crOca = new RunCrystal();
            //crOca.SetSubject("Profit by Customer");
            //crOca.SetToAddress("t.mcginnis@teammodern.com");
            //crOca.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Beverage Bar Auto-Run Updated OCA.pdf");
            //crOca.SetAttachments("D:\\Programs\\Profit by Customer PDF and Email\\Profit by Customer Foodservice Auto-Run Updated OCA.pdf");
            //crOca.SendEmail();
        }
    }
}
