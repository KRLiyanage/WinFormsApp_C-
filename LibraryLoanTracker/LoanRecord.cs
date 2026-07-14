using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLoanTracker
{
    public class LoanRecord
    {
        public string LoanId { get; set; }
        public string BookTitle { get; set; }
        public string BorrowerName {  get; set; }
        public string BorrowerType { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; } = false;
        public bool IsOverdue => !IsReturned && DateTime.Today > DueDate;
        public string DisplayText =>$"[{LoanId}] {BookTitle}-- {BorrowerName} ({BorrowerType}) | Due: {DueDate:dd MMM yyyy}{(IsOverdue ? " OVERDUE" : "")}{(IsReturned ?" RETURNED" : "")}";

    }
}
