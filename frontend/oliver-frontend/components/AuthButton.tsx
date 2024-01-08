import { createClient } from '@/utils/supabase/server'
import Link from 'next/link'
import { cookies } from 'next/headers'
import { redirect } from 'next/navigation'

export default async function AuthButton() {
  const cookieStore = cookies()
  const supabase = createClient(cookieStore)

  //this gets the user from authentication
  const {
    data: { user },
  } = await supabase.auth.getUser();
  
  //get the userid
  const userId = user?.id;


  //gets the user in the table
  const { data: users } = await supabase.from("users").select().eq('user_id', userId).single();

  const signOut = async () => {
    'use server'

    const cookieStore = cookies()
    const supabase = createClient(cookieStore)
    await supabase.auth.signOut()
    return redirect('/login')
  }
  // console.log(user)


  const { data } = await supabase
  .storage
  .from('user_images')
  .getPublicUrl(users?.user_image)

  return user ? (
    <div className="flex items-center gap-4">
      <Link href="/user">{users?.user_name}</Link>
      <img src={data?.publicUrl} className="w-14 rounded-lg"/>
      <form action={signOut}>
        <button className="py-2 px-4 rounded-md no-underline">
          Logout
        </button>
      </form>
    </div>
  ) : (
    <Link
      href="/login"
      className="py-2 px-3 flex rounded-md no-underline"
    >
      Login
    </Link>
  )
}