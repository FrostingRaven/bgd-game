using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("AnimationRigging")]
	public class SetRigWeight : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Rig))]
		[Tooltip("The Game Object to play the animation on. NOTE: Must have an Animation Component.")]
		public FsmOwnerDefault gameObject;
		public FsmFloat Weight;
		private Rig _rig;
		public bool Everyframe;
	
		public override void OnEnter()
		{
			_rig = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<Rig>();
			if(!Everyframe)
            {
				SetWeight();
				Finish();
            }
		}
        public override void OnUpdate()
        {
           if(Everyframe)
            {
				SetWeight();
            }
        }
        public void SetWeight()
        {	
				_rig.weight = Weight.Value;
		}
	}
}
