using Npgsql;

namespace cat.itb.M6UF2Pr
{
    public class ProductCRUD : CRUD<Product>
    {
        public Product SelectByCode(int id)
        {
            using EmployeeCRUD empCRUD = new EmployeeCRUD();
            NpgsqlCommand sql = new NpgsqlCommand("select * from id=@id");
            sql.Parameters.AddWithValue("id", id);

            NpgsqlDataReader queryResult = ExecutePreparedStatementQuery(sql);

            queryResult.Read();

            return new Product()
            {
                Id = (int)queryResult[0],
                Code = (int)queryResult[1],
                Description = (string)queryResult[2],
                CurrentStock = (int)queryResult[3],
                MinStock = (int)queryResult[4],
                Price = (int)queryResult[5],
                Responsible = empCRUD.SelectById((int)queryResult[6])
            };
        }
        public bool UpdateADO(Product product)
        {
            NpgsqlCommand sql = new NpgsqlCommand("UPDATE PRODUCT SET code=@code,currentstock=@curStock WHERE id=@id");

            sql.Parameters.AddWithValue("code",product.Code);
            sql.Parameters.AddWithValue("curStock",product.CurrentStock);
            sql.Parameters.AddWithValue("id",product.Id);
        }
    }
}
