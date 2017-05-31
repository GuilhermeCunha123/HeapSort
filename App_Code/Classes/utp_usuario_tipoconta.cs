using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de utp_usuario_tipoconta
/// </summary>
public class utp_usuario_tipoconta
{
    private tip_tipoconta tip_id;
    private usu_usuario usu_id;

    public tip_tipoconta Tip_id
    {
        get
        {
            return tip_id;
        }

        set
        {
            tip_id = value;
        }
    }

    public usu_usuario Usu_id
    {
        get
        {
            return usu_id;
        }

        set
        {
            usu_id = value;
        }
    }
}