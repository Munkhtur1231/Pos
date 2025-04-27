using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using PosLibrary;

namespace Pos;

    public class Print
    {
        private OrderedProductList orderedProductList;

        public void PrintReceipt(OrderedProductList orders)
        {
            orderedProductList = orders;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.PrinterSettings = printDialog.PrinterSettings;
                    printDocument.Print();
                }
            }
        }
    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics graphics = e.Graphics;
        Font font = new Font("Arial", 12);
        float lineHeight = font.GetHeight();
        float x = 50; // Left margin
        float y = 50; // Top margin

        // Load and draw the logo
        try
        {
            Image logo = Image.FromFile("logo.png");
            graphics.DrawImage(logo, x, y, 150, 100); // Draw logo at the top-left corner
            y += 100; // Adjust y position to leave space for the logo
        }
        catch (Exception ex)
        {
            // Handle cases where the logo file is missing or cannot be loaded
            graphics.DrawString("Logo not found", font, Brushes.Red, x, y);
            y += lineHeight;
        }

        // Print header
        //graphics.DrawString("Receipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
        y += lineHeight * 2;

        // Print column headers
        graphics.DrawString("ID", font, Brushes.Black, x, y);
        graphics.DrawString("Product", font, Brushes.Black, x + 100, y);
        graphics.DrawString("Qty", font, Brushes.Black, x + 300, y);
        graphics.DrawString("Price", font, Brushes.Black, x + 350, y);
        graphics.DrawString("Total", font, Brushes.Black, x + 450, y);
        y += lineHeight;

        // Print each order
        foreach (var order in orderedProductList.OrderedProducts)
        {
            graphics.DrawString(order.Id.ToString(), font, Brushes.Black, x, y);
            graphics.DrawString(order.Name, font, Brushes.Black, x + 100, y);
            graphics.DrawString(order.Quantity.ToString(), font, Brushes.Black, x + 300, y);
            graphics.DrawString(order.Price.ToString() + "₮", font, Brushes.Black, x + 350, y);
            graphics.DrawString(order.TotalPrice.ToString() + "₮", font, Brushes.Black, x + 450, y);
            y += lineHeight;
        }

        // Print footer
        y += lineHeight;
        double grandTotal = orderedProductList.OrderedProducts.Sum(o => o.TotalPrice);
        graphics.DrawString("Total Price: " + grandTotal + "₮", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
    }
}

