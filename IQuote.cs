using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DealerSite.Models.Domain
{
    /// <summary>
    /// Domain entity contract.
    /// </summary>
    public interface IQuote
    {
//        IQuote newInstance();
        Int64 quote_number { get; set; }
        Int32 contractor_id { get; set; }
        IList<IMeasure> Measures { get; set; }
        IContractor ContractedThrough { get; set; }
        ICosigning Cosigning { get; set; }
        IQuoteStatus QuoteStatus { get; set; }
        String investor_code { get; set; }
        String sponsor_id { get; set; }
        String installed_measure { get; set; }
        String prefix { get; set; }
        String gen { get; set; }
        String first_name { get; set; }
        String middle { get; set; }
        String last_name { get; set; }
        String ssn { get; set; }
        DateTime? DOB { get; set; }
        String home_ph { get; set; }
        String cell_ph { get; set; }
        String email { get; set; }
        String mail_addr1 { get; set; }
        String mail_addr2 { get; set; }
        String mail_city { get; set; }
        String mail_state { get; set; }
        String mail_zip { get; set; }
        String Isinstall_same_address { get; set; }
        String install_addr1 { get; set; }
        String install_city { get; set; }
        String install_state { get; set; }
        String install_zip { get; set; }
        String emp_status { get; set; }
        Int32? emp_occ { get; set; }
        String employer_name { get; set; }
        String emp_addr { get; set; }
        String emp_city { get; set; }
        String emp_st { get; set; }
        String emp_zip { get; set; }
        String work_ph { get; set; }
        DateTime? hire_date { get; set; }
        String IsEmployed_by_dlr { get; set; }
        String IsSelfEmpYN { get; set; }
        String IsEmployedYN { get; set; }
        Decimal? stated_income { get; set; }
        Int64? annual_income { get; set; }
        String income_range { get; set; }
        String extra_inc1_src { get; set; }
        Int64? extra_income1 { get; set; }
        String extra_inc2_src { get; set; }
        Int64? extra_income2 { get; set; }
        String AnyForeclosureYN { get; set; }
        String AnyBKYN { get; set; }
        Int32? years_residing { get; set; }
        String prop_type { get; set; }
        String prop_occ { get; set; }
        Decimal? prop_assessed_value { get; set; }
        String mortgage_holder { get; set; }
        Int32? mo_mortgage { get; set; }
        Decimal? invoice_amt { get; set; }
        Decimal? downpayment { get; set; }
        Int16? term { get; set; }
        Decimal? amount_financed { get; set; }
        Decimal? stamp_tax { get; set; }
        String Isco_same_address { get; set; }
        DateTime? date_received { get; set; }
        String quote_status { get; set; }
        // This property is a temporary workaround for Kendo UI's problems with filtering nested JSON data...
        //String quote_status_description { get; set; }
        Decimal? loan_rate { get; set; }
        DateTime? int_start_date { get; set; }
        //String quote_status_str { get; set; }
        String Pending { get; set; }
    }

    /// <summary>
    /// Domain entity contract.
    /// </summary>
    public interface IMeasure
    {
        String measure_id { get; set; }
        Int64 quote_number { get; set; }
        String measure_description { get; set; }
        Int32 sortby { get; set; }
//        IList<IQuote> Quotes { get; set; }
    }

    /// <summary>
    /// Domain entity contract.
    /// </summary>
    public interface ICosigning
    {
        Int64 quote_number { get; set; }
        String co_prefix { get; set; }
        String co_gen { get; set; }
        String co_first_name { get; set; }
        String co_middle { get; set; }
        String co_last_name { get; set; }
        String co_ssn { get; set; }
        DateTime? co_DOB { get; set; }
        String co_home_ph { get; set; }
        String co_cell_ph { get; set; }
        String co_email { get; set; }
        String co_mail_addr1 { get; set; }
        String co_mail_addr2 { get; set; }
        String co_mail_city { get; set; }
        String co_mail_state { get; set; }
        String co_mail_zip { get; set; }
        String co_emp_status { get; set; }
        Int32? co_emp_occ { get; set; }
        String co_employer { get; set; }
        String co_emp_addr { get; set; }
        String co_emp_city { get; set; }
        String co_emp_st { get; set; }
        String co_emp_zip { get; set; }
        String co_work_ph { get; set; }
        DateTime? co_hire_date { get; set; }
        String co_IsEmployed_by_dlr { get; set; }
        String co_IsSelfEmpYN { get; set; }
        String co_IsEmployedYN { get; set; }
        Decimal? co_stated_income { get; set; }
        Int64? co_annual_income { get; set; }
        String co_income_range { get; set; }
        String co_AnyForeclosureYN { get; set; }
        String co_AnyBKYN { get; set; }
    }


    /// <summary>
    /// Domain entity contract.
    /// </summary>
    public interface IAllocated
    {
        Int64 quote_number { get; set; }
    }

    /// <summary>
    /// Domain entity contract.
    /// </summary>
    public interface IListedResult
    {
        String Value { get; set; }
        String Choices { get; set; }
    }

}
