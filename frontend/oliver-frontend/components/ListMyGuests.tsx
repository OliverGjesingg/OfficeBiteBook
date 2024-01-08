import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
// import { headers, cookies } from 'next/headers'
import DeleteGuestButton from "./DeleteGutstbutton";

interface Props {
  userId: {
    userId: any;
  };
}

export default async function ListMyGuests({ userId }: Props) {

  const cookieStore = cookies();
  const supabase = createClient(cookieStore);
  const { data: guests, error } = await supabase.from("guest").select();
  return (
    <div>
      {guests?.map((guest) => (
          <div key={guest.id} className="relative my-5 border border-black p-5 flex flex-row w-3/4 mx">
              <div className="flex flex-col w-1/2">
              <h1 className="mr-5">{guest.guest_day}</h1>
              <p>{guest.guest_amount} Gæster</p>
              <p>{guest.guest_description}</p>
              </div>
              <div className="w-1/2 text-right">
              <DeleteGuestButton userId={userId} guest={guest}/>
              </div>
          </div>
          )
        )}
    </div>
  );
};