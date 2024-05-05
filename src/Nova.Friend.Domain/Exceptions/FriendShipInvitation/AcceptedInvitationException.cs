namespace Nova.Friend.Domain.Exceptions.FriendShipInvitation;

public class AcceptedInvitationException : DomainException
{
    public AcceptedInvitationException(string invitationId)
        : base($"Invitation with id {invitationId} should be in pending status to be accepted")
    {
    }
}