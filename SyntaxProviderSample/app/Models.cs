namespace MyApp;

partial class Order
{
    public required string OrderID {get;set;}
    public decimal Quantity {get;set;}
    public decimal Price {get;set;}
    public required string SecurityID {get;set;}
}

partial class Execution
{
    public required string ExecutionID {get;set;}
    public decimal AvgPrice {get;set;}
    public decimal Quantity {get;set;}
}