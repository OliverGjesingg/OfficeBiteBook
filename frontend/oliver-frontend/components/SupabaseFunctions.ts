// supabaseFunctions.ts
import { cookies } from 'next/headers';
import { createClient } from '@/utils/supabase/server';

export const uploadGuest = async (formData: FormData) => {
  'use server';

  const cookieStore = cookies();
  const supabase = createClient(cookieStore);

  // Rest of your server-specific logic here...
};
