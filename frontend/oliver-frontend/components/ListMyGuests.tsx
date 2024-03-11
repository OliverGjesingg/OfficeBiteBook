import DeleteGuestButton from "./DeleteGuetstbutton";

interface Props {
  userId: {
    userId: any;
  };
  guests: any[];
}

export default function ListMyGuests({ userId, guests }: Props) {
  const filteredGuests = guests.filter((guest) => guest.user_id == userId.userId);


  return (
    <div>
      {filteredGuests.map((guest) => {
        const guestDate = new Date(guest.guest_day);
        const formattedDate = `${guestDate.getDate()}-${guestDate.getMonth() + 1}-${guestDate.getFullYear()}`;
        
        var startDate = new Date();
        var timeDiff  = guestDate.getTime() - startDate.getTime();
        var caldate = Math.floor(timeDiff / (1000 * 3600 * 24));
        if(caldate >= -1){
          return (
          <div key={guest.id} className="relative my-5 border border-black p-5 flex flex-row w-3/4 mx">
            <div className="flex flex-col w-1/2">
              <h1 className="mr-5">{formattedDate}</h1>
              <p>{guest.guest_amount} Gæster</p>
              <p>{guest.guest_description}</p>
            </div>
            <div className="w-1/2 text-right">
              <DeleteGuestButton userId={userId} guest={guest} />
            </div>
          </div>
        );
        }
        else{
          return(
            <></>
          );
        }

        
      })}
    </div>
  );
};
