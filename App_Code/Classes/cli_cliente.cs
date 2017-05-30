using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cli_cliente
/// </summary>
public class cli_cliente
{
    private int cli_id;
    private string cli_nome;
    private string cli_cpf;
    private string cli_sexo;
    private string cli_datanascimento;
    private string cli_cidade;
    private string cli_estado;
    private int cli_idade;
    private usu_usuario usu_id;

    public global:: usu_usuario Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }

    public int Cli_idade
    {
        get { return cli_idade; }
        set { cli_idade = value; }
    }

    public string Cli_estado
    {
        get { return cli_estado; }
        set { cli_estado = value; }
    }

    public string Cli_cidade
    {
        get { return cli_cidade; }
        set { cli_cidade = value; }
    }

    public string Cli_datanascimento
    {
        get { return cli_datanascimento; }
        set { cli_datanascimento = value; }
    }

    public string Cli_sexo
    {
        get { return cli_sexo; }
        set { cli_sexo = value; }
    }


    public string Cli_cpf
    {
        get { return cli_cpf; }
        set { cli_cpf = value; }
    }

    public string Cli_nome
    {
        get { return cli_nome; }
        set { cli_nome = value; }
    }

    public int Cli_id
    {
        get { return cli_id; }
        set { cli_id = value; }
    }
}