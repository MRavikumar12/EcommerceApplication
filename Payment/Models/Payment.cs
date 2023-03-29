namespace Payment.Models
{
    public class Payment
    {
          public string? PaymentId { get; set; }
          public string? OrderId { get; set; }
          public string? UserId { get; set; }
          public string? PaymentMethod { get; set; }
          public string? PaymentStatus { get; set; }


    }
}
