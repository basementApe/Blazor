    
    namespace Xiangqi.Game;

    enum PieceColor { Empty, Red, Blue }
    enum PieceType { None, Chariot, Horse, Elephant, Advisor, King, Cannon, Pawn }

    record Piece(PieceType Type, PieceColor Color, string Key);


