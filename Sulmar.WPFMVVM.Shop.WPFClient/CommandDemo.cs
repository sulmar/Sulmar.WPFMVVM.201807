using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.WPFClient.CommandDemo
{
    class Customer
    {
        public void Send(string from, string to, string subject, string content)
        {
            Console.WriteLine($"from {from} to {to} : {content}");
        }

        public bool CanSend()
        {
            return true;
        }

        public void Print()
        {

        }

        public bool CanPrint()
        {
            return false;
        }
    }


    interface ICommand
    {
        void Execute();

        bool CanExecute();
    }

    class SendCommand : ICommand
    {
        private string from;
        private string to;
        private string subject;
        private string content;

        public SendCommand(string from, string to, string subject, string content)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
            this.content = content;
        }

        public bool CanExecute()
        {
            return !string.IsNullOrEmpty(to);
        }

        public void Execute()
        {
            Console.WriteLine($"from {from} to {to} : {content}");
        }
    }


    public class Demo
    {
        public void Test()
        {
            ICommand command = new SendCommand("marcin.su", "", "Subject", "Hello world");

            command.Execute();
        }
    }




}
