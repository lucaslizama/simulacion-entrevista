using System.Text;

public class Challenge
{
    private List<Bank> banks = new List<Bank>
    {
        new Bank(1, "SANTANDER"),
        new Bank(2, "CHILE"),
        new Bank(3, "ESTADO")
    };

    private List<Client> clients = new List<Client>
    {
        new Client(1, "86620855", "HECTOR ACUÑA BOLAÑOS"),
        new Client(2, "7317855K", "JESUS RODRIGUEZ ALVAREZ"),
        new Client(3, "73826497", "ANDRES NADAL MOLINA"),
        new Client(4, "88587715", "SALVADOR ARNEDO MANRIQUEZ"),
        new Client(5, "94020190", "VICTOR MANUEL ROJAS LUCAS"),
        new Client(6, "99804238", "MOHAMED FERRE SAMPER"),
    };

    private List<Account> accounts = new List<Account>
    {
        new Account(6, 1, 15000),
        new Account(1, 3, 18000),
        new Account(5, 3, 135000),
        new Account(2, 2, 5600),
        new Account(3, 1, 23000),
        new Account(5, 2, 15000),
        new Account(3, 3, 45900),
        new Account(2, 3, 19000),
        new Account(4, 3, 51000),
        new Account(5, 1, 89000),
        new Account(1, 2, 1600),
        new Account(5, 3, 37500),
        new Account(6, 1, 19200),
        new Account(2, 3, 10000),
        new Account(3, 2, 5400),
        new Account(3, 1, 9000),
        new Account(4, 3, 13500),
        new Account(2, 1, 38200),
        new Account(5, 2, 17000),
        new Account(1, 3, 1000),
        new Account(5, 2, 600),
        new Account(6, 1, 16200),
        new Account(2, 2, 10000),
    };

    /// <summary>
    /// 0. Mostrar arreglo con los IDs de los clientes.
    /// </summary>
    public string ListClientIds()
    {
        int[] ids = new int[clients.Count];

        for (int i = 0; i < clients.Count; i++)
        {
            ids[i] = clients[i].Id;
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        foreach (int id in ids)
        {
            sb.Append(id.ToString() + ", ");
        }

        sb.Append("]");

        return sb.ToString();
    }

    /// <summary>
    /// 1. Mostrar arreglo con los IDs de los clientes
    /// ordenados por rut.
    /// </summary>
    public string ListClientIdsSortByTaxNumber()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 2. Mostrar arreglo con los nombres de los clientes
    /// ordenados de mayor a menor por la suma TOTAL de 
    /// los saldos de cada cliente en los bancos en los
    /// que participa.
    /// </summary>
    public string SortClientsTotalBalances()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 3. Mostrar objeto donde las claves sean los nombres
    /// de los bancos y los valores sean un arreglo con 
    /// los ruts de esus clientes ordenados alfabeticamente
    /// por nombre.
    /// </summary
    public string BanksClientsRutNumbers()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 4. Mostrar arreglo con los saldos de lo clientes que
    /// tengan mas de 25.000 pesos en el banco SANTANDER
    /// ordenados decrecientemente.
    /// </summary>
    public string RichClientsBalances()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 5. Mostrar arreglo con los IDs de los bancos ordenados
    /// crecientemente por la cantidad TOTAL de dinero que
    /// administran.
    /// </summary>
    public string BanksRankingByTotalBalance()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 6. Mostrar objeto donde las claves sean los nombres de
    /// los bancos y los valores el numero de clientes que
    /// solo tengan cuenta en ese banco.
    /// </summary>
    public string BanksFidelity()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 7. Mostrar objeto donde las claves sean los nombres de
    /// los bancos y los valores el ID de su cliente con
    /// menos dinero
    /// </summary>
    public string BanksPoorClients()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 8. Agregar nuevo cliente con datos ficticios a "clientes"
    /// y agregar una cuenta en el BANCO ESTADO con un sueldo
    /// de 9000 para este nuevo empleado.
    /// 
    /// Luego mostrar el lugar que ocupa este cliente en el 
    /// ranking de la pregunta 2.
    /// 
    /// No modificar listas originales para no alterar las
    /// respuestas anteriores al correr la solucion.
    /// </summary>
    public string NewClientRanking()
    {
        throw new NotImplementedException();
    }
}