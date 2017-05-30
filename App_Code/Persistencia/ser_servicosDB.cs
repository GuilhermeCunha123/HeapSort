using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for ser_servicosDB
/// </summary>
public class ser_servicosDB
{
    public static int Insert(ser_servicos ser)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into ser_servicos ";
            sql += "(ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_lugares, mot_id)";
            sql += "values ";
            sql += "(?ser_datainicio, ?ser_datafim, ?ser_origem, ?ser_destino, ?ser_lugares, ?mot_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?ser_datainicio", ser.Ser_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datafim", ser.Ser_datafim));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_origem", ser.Ser_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_destino", ser.Ser_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_lugares", ser.Ser_lugares));

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", ser.Mot_id.Mot_id));

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
        string sql = "select * from ser_servicos";

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
            string sql = "delete from ser_servicos where usu_id = ?ser_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", id));

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