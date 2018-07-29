namespace WhiteWalkersGames.SourceEngine.Modules.Rules
{
    internal class MoveEvaluator : IMoveEvaluator
    {
        public MoveEvaluationResult EvaluateMove(IMoveEvaluatorContext moveEvaluatorContext)
        {
            return EvaluateMoveInternal(moveEvaluatorContext);
        }

        private MoveEvaluationResult EvaluateMoveInternal(IMoveEvaluatorContext moveEvaluatorContext)
        {
            //Things to do here.




            //Check if move is possible
            //If yes then Perform scoring



            return null;
        }
    }
}
