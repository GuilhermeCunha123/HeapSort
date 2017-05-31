using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for mot_motorista
/// </summary>
public class mot_motoristaDB
{
    public static int Insert(mot_motorista mot)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into mot_motorista ";
            sql += "(mot_nome, mot_idade, mot_sexo, mot_cidade, mot_estado, usu_id)";
            sql += "values ";
            sql += "(?mot_nome, ?mot_idade, ?mot_sexo, ?mot_cidade, ?mot_estado, ?usu_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?mot_nome", mot.Mot_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_idade", mot.Mot_idade));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", mot.Mot_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_cidade", mot.Mot_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_estado", mot.Mot_estado));

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", mot.Usu_id));

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
        string sql = "select * from mot_motorista";

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
            string sql = "delete from mot_motorista where mot_id = ?mot_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", id));

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