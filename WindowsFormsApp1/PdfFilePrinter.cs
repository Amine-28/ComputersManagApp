using System;

namespace WindowsFormsApp1
{
    internal class PdfFilePrinter
    {
        private string v;
        private string printerName;

        public PdfFilePrinter(string v, string printerName)
        {
            this.v = v;
            this.printerName = printerName;
        }

        internal void Print()
        {
            throw new NotImplementedException();
        }
    }
}