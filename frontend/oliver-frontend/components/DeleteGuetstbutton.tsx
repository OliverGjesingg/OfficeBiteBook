'use client'

// import { headers, cookies } from 'next/headers'
import { uploadGuest } from './SupabaseFunctions';
import {supabase} from '@/components/SupabaseClient'

interface Props {
    userId: {
      userId: any;
    };
    guest: {
        id: any;
    }
  }

export default function DeleteGuestButton({ userId, guest }: Props) {

  const deleteGuest = async () => {
try{
    if(supabase){
    const { error } = await supabase.from('guest').delete().eq('user_id', userId.userId ).eq("id", guest.id)
    location.reload()
        }
        
}catch (error) {
    console.error("Error deleting data", error);
  }
    
}
  return (
    <div>
      <button onClick={deleteGuest} className='bg-red-600 p-1 text-zinc-50 rounded hover:bg-red-700 ease-out duration-300'>fjern gæst</button>
    </div>
  );
};