using QuestionBank.Domain.Entities.Common;
namespace QuestionBank.Domain.Entities;
using QuestionBank.Shared;
public class Interview : BaseDomainEntity   
{
    public string Role { get; set; } = null!;
    public InterviewStatus Status { get; set; } = InterviewStatus.New!;
    public float? Experience { get; set; }

    public ICollection<InterviewSkill> InterviewSkills { get; set; } = new List<InterviewSkill>();
    public ICollection<Question> Questions { get; set; } = new List<Question>();
}
