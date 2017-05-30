using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
/// <summary>
/// Summary description for Mapped
/// </summary>
public class Mapped
{
    //Método para abrir conexão
    public static IDbConnection Connection()
    {
        MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["strConexao"]);
        objConexao.Open(); return objConexao;
    }
    //Comandos SQL - Cria o objeto e valida o comando a ser executado
    public static IDbCommand Command(string query, IDbConnection objConexao)
    {
        IDbCommand command = objConexao.CreateCommand();
        command.CommandText = query;
        return command;
    }
    //Funciona como uma ponte entre os dados desconexos e conexos
    public static IDataAdapter Adapter(IDbCommand command)
    {
        IDbDataAdapter adap = new MySqlDataAdapter();
        adap.SelectCommand = command; return adap;
    }
    //Paramentrização
    //Valida as entradas de dados antes de executar o comando Sql
    public static IDbDataParameter Parameter(string nomeDoParametro, object valor)
    {
        return new MySqlParameter(nomeDoParametro, valor);
    }
	
}