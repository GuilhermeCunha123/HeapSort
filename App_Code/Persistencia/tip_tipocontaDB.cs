using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de tip_tipoconta
/// </summary>
public class tip_tipocontaDB
{
    public static int Insert(tip_tipoconta tip)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into tip_tiporista ";
            sql += "(tip_descricao)";
            sql += "values ";
            sql += "(?tip_descricao)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?tip_nome", tip.Tip_descricao));
            

            // Chave estrangeira
       

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        }
        catch (Exception)
        {
            //erro
            retorno = -2;
        }
        return retorno;
    }

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select * from tip_tipoconta";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static int Delete(int id)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "delete from tip_tipoconta where tip_id = ?tip_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?tip_id", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        }
        catch (Exception)
        {
            //erro
            retorno = -2;
        }
        return retorno;
    }
    public static int Update(tip_tipoconta tip)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update tip_tipoconta set tip_descricao = ?tip_descricao where tip_id = ?tip_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tip_descricao", tip.Tip_descricao));
            

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        }
        catch (Exception)
        {
            //erro
            retorno = -2;
        }
        return retorno;
    }
}