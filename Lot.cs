using System.Text.RegularExpressions;

namespace LotNumber
{
    public class Lot
    {
        private static readonly string LOT_PATTERN = @"([A-Za-z-()]+|\d+)";

        public Lot(string lot)
        {
            var parsed = Parse(lot);

            IsSuccessful = parsed != null;

            if (parsed != null)
            {
                LotAbbr = parsed.Value.LotAbbr;
                LotNumber = parsed.Value.LotNumber;
            }
        }

        public bool IsSuccessful { get; private set; } = false;

        public string LotAbbr { get; private set; } = string.Empty;

        public string LotNumber { get; private set; } = string.Empty;

        public (string LotAbbr, string LotNumber)? Parse(string lot)
        {
            var matches = Regex.Matches(lot, LOT_PATTERN).Select(g => g.Value).ToList();

            if (!matches.Any())
            {
                return null;
            }

            var isLotNo = int.TryParse(matches.Last(), out int lotNo);

            if (!isLotNo)
            {
                return (string.Join(" ", matches), 0.ToString());
            }
            else
            {
                return (string.Join(" ", matches.SkipLast(1)), lotNo.ToString());
            }
        }
    }
}
