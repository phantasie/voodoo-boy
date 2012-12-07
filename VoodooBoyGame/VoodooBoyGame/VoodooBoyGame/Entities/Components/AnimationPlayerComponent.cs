﻿using Artemis;
using Microsoft.Xna.Framework;
using System;
using Demina;

namespace VoodooBoyGame
{
    public class AnimationPlayerComponent : Component
    {
        private AnimationPlayer animationPlayer;

        public AnimationPlayer AnimationPlayer
        {
            get { return animationPlayer; }
            set { animationPlayer = value; }
        }

        public float Speed
        {
            get { return animationPlayer.PlaySpeedMultiplier; }
            set { animationPlayer.PlaySpeedMultiplier = value; }
        }

        public AnimationPlayerComponent()
        {
            animationPlayer = new AnimationPlayer();
        }

        public void AddAnimation(string name, Animation animation)
        {
            animationPlayer.AddAnimation(name, animation);
        }

        public void StartAnimation(string name)
        {
            animationPlayer.StartAnimation(name);
        }

        public void Transition(string name, float time)
        {
            animationPlayer.TransitionToAnimation(name, time);
        }
    }
}
