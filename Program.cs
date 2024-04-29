// See https://aka.ms/new-console-template for more information
using LotNumber;

var lot1 = new Lot("DD87 339"); // DD 87, 339
var lot2 = new Lot("DD 37 TLL 105"); // DD 37 TLL 105
var lot3 = new Lot("DD274TLLOTaxlordLot 147"); // DD 274 TLLOTaxlordLot 147
var lot4 = new Lot("HL-YL"); // HL-YL 0
var lot5 = new Lot("GLA-DS(T) 1234"); // HL-YL 0

var lots = new List<Lot>() { lot1, lot2, lot3, lot4, lot5 };

foreach (var lot in lots)
{
    Console.WriteLine(lot.IsSuccessful);
    Console.WriteLine(lot.LotAbbr);
    Console.WriteLine(lot.LotNumber);
    Console.WriteLine();
}