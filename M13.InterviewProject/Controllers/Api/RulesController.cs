using System.Threading.Tasks;
using M13.Domain.Constants;
using M13.Domain.Models.Rules;
using M13.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace M13.InterviewProject.Controllers.Api
{
    public class RulesController : BaseApiController
    {
        #region Private fields

        private readonly IRuleService _ruleService;

        #endregion

        #region Ctor

        public RulesController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }

        #endregion

        [HttpPost(ApiRouteConstants.DefaultApiAction)]
        public IActionResult Add([FromBody] ApplyRuleModel model)
        {
            var result = _ruleService.Add(model);

            return ResultFromService(result);
        }

        [HttpGet(ApiRouteConstants.DefaultApiAction + "/{site}")]
        public ActionResult<RuleGetModel> Get(string site)
        {
            var result = _ruleService.GetRuleBySite(site);

            return Ok(result);
        }

        [HttpPost(ApiRouteConstants.DefaultApiAction)]
        public async Task<ActionResult<GetRuleTestModel>> Test([FromBody] RuleTestModel model)
        {
            var result = await _ruleService.TestAsync(model, _cancellationToken);

            return Ok(result);
        }

        [HttpPost(ApiRouteConstants.DefaultApiAction)]
        public IActionResult Delete([FromBody] DeleteRuleModel model)
        {
            var result = _ruleService.DeleteRuleBySite(model.Site);

            return ResultFromService(result);
        }
    }
}