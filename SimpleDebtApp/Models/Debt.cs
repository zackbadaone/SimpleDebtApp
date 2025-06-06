using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
namespace SimpleDebtApp.Models;
[Table("Debt")]
public partial class Debt : ObservableObject
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [ObservableProperty]
    private string? debtName;
    [ObservableProperty]
    private decimal amount;
}
