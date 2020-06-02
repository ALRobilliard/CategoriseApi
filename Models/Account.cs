using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CategoriseApi.Models
{
  public class Account
  {
    [Key]
    public Guid AccountId { get; set; }
    [Required]
    [MaxLength(25)]
    public string AccountName { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedOn { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedOn { get; set; }

    public Guid UserId { get; set; }
    [ForeignKey("UserForeignKey")]
    public User User { get; set; }

    public List<Transaction> Transactions { get; set; }
  }
}