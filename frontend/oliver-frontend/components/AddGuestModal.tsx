"use client"
import AddGuest from './AddGuest';
import ListMyGuests from './ListMyGuests';

import React, { FC, useState } from 'react';

interface AddGuestModalProps {
  userId: any;
  guests: any[];
}

const AddGuestModal: FC<AddGuestModalProps> = ({ userId, guests }) => {
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);

  const openModal = () => {
    setIsModalOpen(true);
  };

  const closeModal = () => {
    setIsModalOpen(false);
  };

  return (
    <div className="mr-5">
    <button onClick={openModal}>Tilføj gæst</button>

    {isModalOpen && (
      <div className="fixed inset-0 z-50 flex items-center justify-center overflow-x-hidden overflow-y-auto outline-none focus:outline-none">
        <div className="relative w-full h-full max-w-md mx-auto my-auto">
          <div className="relative p-6 bg-white shadow-md rounded-md border-solid border-2 border-slate-300 mt-10 mb-10">
            <button
              className="absolute top-0 right-0 mt-4 mr-4 px-3 py-1 text-white bg-red-500 rounded-md hover:bg-red-600 focus:outline-none focus:shadow-outline-red active:bg-red-800"
              onClick={closeModal}
            >
              X
            </button>
            <br />
            <AddGuest userId={userId} />
            <ListMyGuests guests={guests || []} userId={userId} />
          </div>
        </div>
      </div>
    )}
  </div>
  );
};

export default AddGuestModal;
