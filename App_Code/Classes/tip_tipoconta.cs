using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tip_tipoconta
/// </summary>
public class tip_tipoconta
{
    private int tip_id;
    private string tip_descricao;

    public string Tip_descricao
    {
        get { return tip_descricao; }
        set { tip_descricao = value; }
    }

    public int Tip_id
    {
        get { return tip_id; }
        set { tip_id = value; }
    }
}