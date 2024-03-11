import DeployButton from '../components/DeployButton'
import AuthButton from '../components/AuthButton'
import { createClient } from '@/utils/supabase/server'
import ConnectSupabaseSteps from '@/components/ConnectSupabaseSteps'
import SignUpUserSteps from '@/components/SignUpUserSteps'
import Header from '@/components/Header'
import { cookies } from 'next/headers'
// import Menulist from '@/components/MenuList'
import UserList from '@/components/UserList'
import Link from 'next/link'
import Home from '@/components/Home'
import MenuList from '@/components/MenuList'
import Signin from '@/components/SignIn'

export default async function Index() {


  // console.log(user)

  const cookieStore = cookies()
  const supabase = createClient(cookieStore)

  //this gets the user from authentication
  const {
    data: { user },
  } = await supabase.auth.getUser();

  return user ? (
    <div className="flex-1 w-full flex flex-col gap-20">

      <div className="animate-in flex-1 flex flex-col gap-20 opacity-0 px-3">
        <Home/>
      </div>
    </div>
  ) : (
    <>
    <Signin searchParams={{ message: 'YourMessageHere' }}/>
    </>
  )
}
