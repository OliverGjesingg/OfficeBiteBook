import React, { FC, useState } from 'react';

interface AddGuestModalProps {
  userId: any;
}

const AddGuestModal: FC<AddGuestModalProps> = ({ userId }) => {
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
          <div className="relative w-auto max-w-sm mx-auto my-6 w-100">
            <div className="relative p-6 bg-white shadow-md rounded-md">
              {/* <AddGuest userId={userId} />
              <ListMyGuests userId={userId} /> */}
              <button
                className="mt-4 px-4 py-2 text-white bg-red-500 rounded-md hover:bg-red-600 focus:outline-none focus:shadow-outline-red active:bg-red-800"
                onClick={closeModal}
              >
                Close Modal
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default AddGuestModal;
