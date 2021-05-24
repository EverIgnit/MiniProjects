using System;
Limilabs.Client.IMAP.Imap imap = new();
double cashbackVal = 0; 
try
{
    imap.ConnectSSL("imap.mail.ru");
    imap.Login("gbelkevich@bk.ru", "OnlyForward))");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Environment.Exit(0);
}
imap.SelectInbox();
var messagesNums = imap.SearchNumbers(Limilabs.Client.IMAP.Flag.All);
messagesNums.Reverse();
foreach (var messageNum in messagesNums)
{
    var msg = imap.GetMessageInfoByNumber(messageNum).Envelope;
    Console.WriteLine($"\n\n{messageNum} - {msg.From?[0]?.Address} - {msg?.Date.Value.ToShortDateString()}");
    Console.WriteLine(cashbackVal);
    if (msg.From?[0]?.Name.Contains("Белг") ?? false)
    {
        var msgText = new Limilabs.Mail.MailBuilder().CreateFromEml(imap.GetMessageByNumber(messageNum)).GetBodyAsText();
        if (msgText.Contains("сч") &&
            double.TryParse(msgText.Substring(msgText.IndexOf(':') + 2, 5), out double tempCashbackVal)
            && tempCashbackVal < 5)
            cashbackVal += tempCashbackVal;
    }
}
Console.WriteLine(cashbackVal);
