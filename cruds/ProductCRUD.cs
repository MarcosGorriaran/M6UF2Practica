using Npgsql;

namespace cat.itb.M6UF2Pr
{
    public class ProductCRUD : CRUD<Product>
    {
        public Product SelectByCode(int code)
        {
            using EmployeeCRUD empCRUD = new EmployeeCRUD();
            NpgsqlCommand sql = new NpgsqlCommand("SELECT * FROM PRODUCT WHERE code = @code");
            sql.Parameters.AddWithValue("code", code);

            NpgsqlDataReader queryResult = ExecutePreparedStatementQuery(sql);

            queryResult.Read();
            Product product = new Product();
            return new Product()
            {
                Id = queryResult.GetInt32(0),
                Code = queryResult.GetInt32(1),
                Description = queryResult.GetString(2),
                CurrentStock = queryResult.GetInt32(3),
                MinStock = (int)queryResult.GetInt32(4),
                Price = queryResult.GetFloat(5),
                Responsible = empCRUD.SelectById(queryResult.GetInt32(6))
            };
        }
        public bool UpdateADO(Product product)
        {
            NpgsqlCommand sql = new NpgsqlCommand("UPDATE PRODUCT SET currentstock=@curStock WHERE code=@code");

            sql.Parameters.AddWithValue("code",product.Code);
            sql.Parameters.AddWithValue("curStock",product.CurrentStock);

            int updated = ExecutePreparedStatementNonQuery(sql);

            return updated > 0;
        }
    }
}
