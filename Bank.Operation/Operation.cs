namespace Bank.Operation
{
    public class Operation
    {
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string OperationType { get; set; } //расход/приход
        public string Category { get; set; } 
        
        /// <summary>
        /// Номер карты, по которой произошла операция (User.cardNumber)
        /// </summary>
        public int CardNumber { get; set; }

        // Sum;Date;OperationType;Category;CardNumber
        // 100;23.05.2023;Расход;Продукты;54330022
    }
}