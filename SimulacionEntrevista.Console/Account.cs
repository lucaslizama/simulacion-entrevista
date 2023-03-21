public class Account
{
    private int clientId;
    private int bankId;
    private int balance;

    public int ClientId
    {
        get { return clientId; }
        set { clientId = value; }
    }

    public int BankId
    { 
        get { return bankId; }
        set { bankId = value; }
    }

    public int Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public Account(int clientId, int bankId, int balance)
    {
        this.clientId = clientId;
        this.bankId = bankId;
        this.balance = balance;
    }

    public override string ToString()
    {
        return $"ClientID: {clientId}, BankID: {bankId}, Balance: {balance}";
    }
}