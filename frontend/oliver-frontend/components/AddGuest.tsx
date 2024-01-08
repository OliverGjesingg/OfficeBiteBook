'use client'

// import { headers, cookies } from 'next/headers'
import { uploadGuest } from './SupabaseFunctions';
import {supabase} from '@/components/SupabaseClient'


interface Props {
  userId: {
    userId: any;
  };
}

export default async function AddGuest({ userId }: Props) {


        
  const handleAccept = async (formData: FormData) => {
    try {
      if (supabase) {
        const Amount = formData.get('amount') as string
        const Description = formData.get('description') as string
        const dateString = formData.get('date') as string;
        const GuestDate = new Date(dateString);

        const { data, error } = await supabase.from("guest").insert([
          {
            guest_amount: Amount, guest_description: Description, user_id: userId.userId, guest_role: "CEO", guest_day: GuestDate
          },
        ]);

        if (error) throw error;
        console.log("Data submitted successfully", data);
      } else {
        console.error("Supabase client is null");
      }
    } catch (error) {
      console.error("Error submitting data", error);
      alert("Alle felterne skal være udfyldt")
    }
  };

  return (
    <div className='flex flex-col w-1/4'>
      <form action={handleAccept}>
      <input name='amount' type="number" className='rounded-md px-4 py-2 bg-inherit border mb-6 border-black' placeholder='Antal gæster'/>
      <input name="date" type='date' className='rounded-md px-4 py-2 bg-inherit border mb-6 border-black'/>
      <textarea name="description" className='rounded-md px-4 py-2 bg-inherit border mb-6 border-black h-24' placeholder='Er der nogle allergier eller mad diæter kokken skal være opmærksom om?'/>
      <button  className='bg-green-600 p-1 text-zinc-50 rounded hover:bg-green-700 ease-out duration-300'>Tilføj gæst</button>
      </form>
      
    </div>
  );
};