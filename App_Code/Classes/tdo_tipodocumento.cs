using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tdo_tipodocumento
/// </summary>
public class tdo_tipodocumento
{
    private int tdo_id;
    private int tdo_obrigatorio;
    private string tdo_descricao;

    public string Tdo_descricao
    {
        get { return tdo_descricao; }
        set { tdo_descricao = value; }
    }

    public int Tdo_obrigatorio
    {
        get { return tdo_obrigatorio; }
        set { tdo_obrigatorio = value; }
    }

    public int Tdo_id
    {
        get { return tdo_id; }
        set { tdo_id = value; }
    }
}