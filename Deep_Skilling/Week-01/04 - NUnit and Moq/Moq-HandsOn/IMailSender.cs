// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: Moq-HandsOn

namespace CustomerCommLib
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }
}