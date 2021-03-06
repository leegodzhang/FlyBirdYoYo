using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Ddk
{
    public partial class QueryDdkZsUnitGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 招商多多客id
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public int ZsDuoId { get; set; }
        /// <summary>
        /// 页码，默认为1
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 每页个数，默认100
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

    }

}
