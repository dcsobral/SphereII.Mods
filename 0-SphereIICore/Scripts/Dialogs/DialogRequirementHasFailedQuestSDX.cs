﻿using UnityEngine;
public class DialogRequirementHasFailedQuestSDX : BaseDialogRequirement
{
    public override bool CheckRequirement(EntityPlayer player)
    {
        if (string.IsNullOrEmpty(Value))
            return false;

        Quest myQuest = player.QuestJournal.FindQuest(Value.ToLower());
        if (myQuest == null)
            return false;

        if (myQuest.CurrentState == Quest.QuestState.Failed)
            return true;
        return false;
    }
}


