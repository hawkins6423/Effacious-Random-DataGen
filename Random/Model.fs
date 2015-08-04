namespace Random.Model
  open System
  type Date = DateTime 
  
  type Loan = 
    { Origination : Date
      Closing     : Date
      Borrower    : BorrowerDetail
      CoBorrower  : BorrowerDetail
      LoanAmount  : decimal
      DownPayment : decimal
      Property    : PropertyDetail }
  and BorrowerDetail =
    { FirstName     : string
      MiddleInitial : char
      LastName      : string
      PhoneNumber   : int }
  and PropertyDetail = 
    { Type    : PropertyType
      Address : string
      City    : string
      State   : string
      Zip     : string}
  and PropertyType = 
    | SingleFamily
    | MultiFamily
    | Condo
    | Farm