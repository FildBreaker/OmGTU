using System;

public class Product
{
    public string[] supplyInfo { get; set; } // ������ � ����������� � ���������
    public string[] salesInfo { get; set; } // ������ � ����������� � ��������
    public string productName { get; set; } // ������������ ������
    public int shelfLife { get; set; } // ���� �������� � ����

    // ����� ��� ������� �������� ������� ������
    public int GetValidStock()
    {
        int validStock = 0;

        // ������ ��� ������� �������� ������� ������

        return validStock;
    }

    // ����� ��� ������� �������� �� ��������
    public int GetWriteOffStock()
    {
        int writeOffStock = 0;

        // ������ ��� ������� �������� �� ��������

        return writeOffStock;
    }

    // ����� ��� ������� ����� ����� ������
    public int GetTotalSales()
    {
        int totalSales = 0;

        // ������ ��� ������� ����� ����� ������

        return totalSales;
    }
}

public class Warehouse
{
    public Product[] products { get; set; } // ������ ������� �� ������

    // ����� ��� ��������� �������� ������� ������ �� ������
    public int GetTotalValidStock()
    {
        int totalValidStock = 0;

        foreach (Product product in products)
        {
            totalValidStock += product.GetValidStock();
        }

        return totalValidStock;
    }

    // ����� ��� ��������� �������� ������ �� ��������
    public int GetTotalWriteOffStock()
    {
        int totalWriteOffStock = 0;

        foreach (Product product in products)
        {
            totalWriteOffStock += product.GetWriteOffStock();
        }

        return totalWriteOffStock;
    }

    // ����� ��� ��������� ����� ����� ������
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
