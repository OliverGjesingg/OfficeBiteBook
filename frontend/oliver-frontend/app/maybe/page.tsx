import Link from 'next/link'
import { headers, cookies } from 'next/headers'
import { createClient } from '@/utils/supabase/server'
import { redirect } from 'next/navigation'
import Header from '@/components/Header'

export default async function Login({
  searchParams,
}: {
  searchParams: { message: string }
}) {
    
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



  return (
    <div className="flex-1  flex flex-col w-full px-8 sm:max-w-md justify-center gap-2">
      <Link
        href="/"
        className=" absolute left-20 top-20 py-2 px-4 rounded-md no-underline text-foreground bg-btn-background hover:bg-btn-background-hover flex items-center group text-sm"
      >
        <svg
          xmlns="http://www.w3.org/2000/svg"
          width="24"
          height="24"
          viewBox="0 0 24 24"
          fill="none"
          stroke="currentColor"
          strokeWidth="2"
          strokeLinecap="round"
          strokeLinejoin="round"
          className="mr-2 h-4 w-4 transition-transform group-hover:-translate-x-1"
        >
          <polyline points="15 18 9 12 15 6" />
        </svg>{' '}
        Back
      </Link>

      <h1 className='text-4xl mt-5'>Sign in</h1>
      <form
        className="animate-in flex-1 flex flex-col w-full gap-2"
        action={update}
      >
        <label className="text-md" htmlFor="name">
          Navn
        </label>
        <input
          className="rounded-md px-4 py-2 bg-inherit border mb-6 border-black"
          name="name"
          defaultValue={users?.user_name}
          required
        />
        <button className="bg-green-700 rounded-md px-4 py-2 text-foreground mb-2">
          Sign In
        </button>
        {searchParams?.message && (
          <p className="mt-4 p-4 bg-foreground/10 text-foreground text-center">
            {searchParams.message}
          </p>
        )}
      </form>
    </div>
  )
}


  const update = async (formData: FormData) => {
    'use server'

    const cookieStore = cookies()
    const supabase = createClient(cookieStore)

        //this gets the user from authentication
        const {
          data: { user },
      } = await supabase.auth.getUser();
      
      //get the userid
      const userId = user?.id;

    const Name = formData.get('name') as string
    
    const { error} = await supabase.from('users').update({ user_name: Name}).eq('user_id', userId);
    // const { error } = await supabase.auth.signInWithPassword({
    //   email,
    //   password,
    // })

    if (error) {
      return redirect('/login?message=Could not authenticate user')
    }

    return redirect('')
  }