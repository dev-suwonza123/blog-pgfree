// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace Kentico.Kontent.Statiq.Memoirs.Models
{
    public partial class GithubGist
    {
        public const string Codename = "github_gist";
        public const string AccountCodename = "account";
        public const string GistIdCodename = "gist_id";
        public const string SubscriptCodename = "subscript";

        public string Account { get; set; }
        public string GistId { get; set; }
        public string Subscript { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}