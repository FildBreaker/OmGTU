using System;

public class Product
{
    public string[] supplyInfo { get; set; } // массив с информацией о поставках
    public string[] salesInfo { get; set; } // массив с информацией о продажах
    public string productName { get; set; } // наименование товара
    public int shelfLife { get; set; } // срок годности в днях

    // метод для выборки остатков годного товара
    public int GetValidStock()
    {
        int validStock = 0;

        // логика для расчета остатков годного товара

        return validStock;
    }

    // метод для выборки остатков на списание
    public int GetWriteOffStock()
    {
        int writeOffStock = 0;

        // логика для расчета остатков на списание

        return writeOffStock;
    }

    // метод для выборки общей суммы продаж
    public int GetTotalSales()
    {
        int totalSales = 0;

        // логика для расчета общей суммы продаж

        return totalSales;
    }
}

public class Warehouse
{
    public Product[] products { get; set; } // массив товаров на складе

    // метод для получения остатков годного товара на складе
    public int GetTotalValidStock()
    {
        int totalValidStock = 0;

        foreach (Product product in products)
        {
            totalValidStock += product.GetValidStock();
        }

        return totalValidStock;
    }

    // метод для получения остатков товара на списание
    public int GetTotalWriteOffStock()
    {
        int totalWriteOffStock = 0;

        foreach (Product product in products)
        {
            totalWriteOffStock += product.GetWriteOffStock();
        }

        return totalWriteOffStock;
    }

    // метод для получения общей суммы продаж
    public int GetTotalSales()
    {
        int totalSales = 0;

        foreach (Product product in products)
        {
            totalSales += product.GetTotalSales();
        }

        return totalSales;
    }
}
