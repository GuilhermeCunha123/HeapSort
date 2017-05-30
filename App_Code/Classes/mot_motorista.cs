using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for mot_motorista
/// </summary>
public class mot_motorista
{
    private int mot_id;
    private string mot_nome;
    private string mot_cnpj;
    private int mot_idade;
    private string mot_sexo;
    private string mot_cidade;
    private string mot_estado;
    private usu_usuario usu_id;

    public global:: usu_usuario Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }

    public string Mot_estado
    {
        get { return mot_estado; }
        set { mot_estado = value; }
    }

    public string Mot_cidade
    {
        get { return mot_cidade; }
        set { mot_cidade = value; }
    }

    public string Mot_sexo
    {
        get { return mot_sexo; }
        set { mot_sexo = value; }
    }

    public int Mot_idade
    {
        get { return mot_idade; }
        set { mot_idade = value; }
    }

    public string Mot_cnpj
    {
        get { return mot_cnpj; }
        set { mot_cnpj = value; }
    }

    public string Mot_nome
    {
        get { return mot_nome; }
        set { mot_nome = value; }
    }

    public int Mot_id
    {
        get { return mot_id; }
        set { mot_id = value; }
    }
}