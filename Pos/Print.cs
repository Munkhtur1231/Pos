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
        Font font = new Font("Arial", 8); 
        float lineHeight = font.GetHeight();
        float x = 10; 
        float y = 10; 
        float maxWidth = 200; 


        try
        {
            Image logo = Image.FromFile("logo.png");

            
            float logoWidth = logo.Width * 60 / logo.Height; 
            float centerX = (maxWidth - logoWidth) / 2; 
            graphics.DrawImage(logo, centerX, y, logoWidth, 60); 

            y += 60; 
        }
        catch (Exception ex)
        {

            graphics.DrawString("Logo not found", font, Brushes.Red, x, y);
            y += lineHeight;
        }


        graphics.DrawString("Welbee's Supermarket", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, x, y);
        y += lineHeight * 2; 

        
        string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
        graphics.DrawString("Date: " + todayDate, font, Brushes.Black, x, y);
        y += lineHeight * 2; 


        
        graphics.DrawString("ID", font, Brushes.Black, x, y);
        graphics.DrawString("Product", font, Brushes.Black, x + 40, y);
        graphics.DrawString("Qty", font, Brushes.Black, x + 120, y); 
        graphics.DrawString("Price", font, Brushes.Black, x + 160, y);
        y += lineHeight;

        
        foreach (var order in orderedProductList.OrderedProducts)
        {
            graphics.DrawString(order.Id.ToString(), font, Brushes.Black, x, y);
            graphics.DrawString(order.Name, font, Brushes.Black, x + 40, y);
            graphics.DrawString(order.Quantity.ToString(), font, Brushes.Black, x + 120, y);
            graphics.DrawString(order.Price.ToString() + "₮", font, Brushes.Black, x + 160, y);
            y += lineHeight;
            if (y > 380) 
            {
                e.HasMorePages = true; 
                return;
            }
        }

        
        double grandTotal = orderedProductList.OrderedProducts.Sum(o => o.TotalPrice);
        y += lineHeight;
        graphics.DrawString("Total: " + grandTotal + "₮", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, x, y);
    }


}

