'use client'

import React, { useState, useEffect } from 'react';

interface ToggleButtonProps {
  onToggle: (isChecked: boolean) => void;
}

const ToggleButton: React.FC<ToggleButtonProps> = ({ onToggle }) => {
  const [isChecked, setIsChecked] = useState(false);

  useEffect(() => {
    // Trigger the onToggle callback when the isChecked state changes
    onToggle(isChecked);
  }, [isChecked, onToggle]);

  const handleToggle = () => {
    setIsChecked((prev) => !prev);
  };

  return (
    <label>
      Toggle:
      <input type="checkbox" checked={isChecked} onChange={handleToggle} />
    </label>
  );
};

export default ToggleButton;