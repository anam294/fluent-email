using System;
using System.IO;
using System.Text;
using FluentEmail.Abstraction;

namespace FluentEmail.Implementation
{
    public class EmailBuilder : IEmailBuilder
    {
        public string BuildEmail(string emailAddress)
        {
            var organization = "Vision Infinitum";
            var membershipId = "001";
            var name = "VI";
            var userName = "Mr. Bob";

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(Resource.EmailHeader);
            stringBuilder.AppendFormat(Resource.EmailText,userName);
            stringBuilder.AppendFormat(Resource.EmailTable, organization, membershipId, name);

            return stringBuilder.ToString();
        }
    }
}

