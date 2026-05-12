using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ders_sql
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            #region 9.ders
            //Console.WriteLine("--------------c# veri tabanı kategori bilgi sistemi---------------");
            //Console.WriteLine();
            //Console.WriteLine("Getrirmek istediğiniz tablonun numarasını girin:\n1-kategoriler\n2-ürünler\n3-siparişler");
            //int tablenumber;
            //tablenumber = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-***;Initial Catalog=EğitimKampiDb;Integrated Security=true");
            //connection.Open();
            //if(tablenumber == 1)
            //{
            //    SqlCommand command = new SqlCommand("select * from TableCategory", connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable datatable = new DataTable();
            //    adapter.Fill(datatable);
            //    connection.Close();
            //    foreach (DataRow row in datatable.Rows)
            //    {
            //        foreach (var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString());
            //            Console.Write("  ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //if (tablenumber == 2)
            //{
            //    SqlCommand command = new SqlCommand("select * from Table_Product", connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable datatable = new DataTable();
            //    adapter.Fill(datatable);
            //    connection.Close();
            //    foreach (DataRow row in datatable.Rows)
            //    {
            //        foreach (var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString());
            //            Console.Write("  ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //if (tablenumber == 3)
            //{
            //    SqlCommand command = new SqlCommand("select * from Table_Order", connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable datatable = new DataTable();
            //    adapter.Fill(datatable);
            //    connection.Close();
            //    foreach (DataRow row in datatable.Rows)
            //    {
            //        foreach (var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString());
            //            Console.Write("  ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //if (tablenumber >= 4 ) 
            //{
            //    Console.WriteLine("3 tane var dedik sana pezevenk.");
            //}
            //if(tablenumber <1)
            //{
            //    Console.WriteLine("Elini kolunu sikim.");
            //}

            #endregion

            #region 10.ders database crud

            //crud--> create - read - update - delete
            Console.WriteLine("menü sipariş paneli");
            Console.WriteLine();
            #region kategori işleme işlemi
            //Console.WriteLine("eklemek istediğiniz kategori adı:");
            //string categoryname = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-***;Initial Catalog=EğitimKampiDb;Integrated Security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TableCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryname);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("kategori başarıyla eklendi");

            #endregion

            #region ürün ekleme işlemi
            string productname;
            decimal productprice;  //decimal = ondalık
            //bool productstatus; bool = true ya da false olarak çalışan meret

            Console.WriteLine("eklemek istediğiniz ürünün adı:");
            productname = Console.ReadLine();
            Console.WriteLine("ürün fiyatı:");
            productprice = decimal.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data source=LAPTOP-***;initial catalog=EğitimKampiDb; integrated security=true"); //initial = baş, ilk.
            //  integrated = entegre, bütünlemiş
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Table_Product (productName,ProductPrice,ProductStatus) values (@productname,@productprice,@productstatus)",connection);
            command.Parameters.AddWithValue("@productname", productname);
            command.Parameters.AddWithValue("@productprice",productprice);
            command.Parameters.AddWithValue("@productstatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("ürün ekleme başarıyla tamamlandı");

            #endregion
            #endregion


            Console.Read();
        }
    }
}
