using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CategoriseApi.Models
{
  /// <summary>
  /// Transaction tag entity model.
  /// </summary>
  public class TransactionTag : BaseEntity
  {
    /// <summary>
    /// Gets or sets the transaction tag name.
    /// </summary>
    [Required]
    [MaxLength(25)]
    public string TransactionTagName { get; set; }

    /// <summary>
    /// Unique identifier of the associated transaction.
    /// </summary>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Associated transaction.
    /// </summary>
    [ForeignKey("TransactionForeignKey")]
    public Transaction Transaction { get; set; }

    /// <summary>
    /// Unique identifier of the owning user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Owning user.
    /// </summary>
    [ForeignKey("UserForeignKey")]
    public User User { get; set; }
  }
}