import React from 'react';

interface WeekProps {
  weekNumber: number;
  onWeekChange: (weekNumber: number) => void;
}

const WeekDisplay: React.FC<WeekProps> = ({ weekNumber, onWeekChange }) => {
  const handlePreviousWeek = () => {
    onWeekChange(weekNumber - 1);
  };

  const handleNextWeek = () => {
    onWeekChange(weekNumber + 1);
  };

  return (
    <div className="w-full">
      <button onClick={handlePreviousWeek}>Back</button>
      <h1 className="text-3xl w-28 mx-auto">Uge {weekNumber}</h1>
      <button onClick={handleNextWeek}>Next</button>
    </div>
  );
};

export default WeekDisplay;
