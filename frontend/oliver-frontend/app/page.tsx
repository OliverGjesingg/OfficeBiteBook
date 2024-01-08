import DeployButton from '../components/DeployButton'
import AuthButton from '../components/AuthButton'
import { createClient } from '@/utils/supabase/server'
import ConnectSupabaseSteps from '@/components/ConnectSupabaseSteps'
import SignUpUserSteps from '@/components/SignUpUserSteps'
import Header from '@/components/Header'
import { cookies } from 'next/headers'
import Menulist from '@/components/MenuList'
import UserList from '@/components/UserList'
import Link from 'next/link'
// import Header from '../components/Header'



// export async function getStaticProps() {
//   const getUsers = cookies()
//   const supabase = createClient(getUsers);
//   const {data: users, error} = await supabase.from("user").select('*')
//   if (error){
//     console.log(error);
//   }
//   return{
//     props: {
//       users,
//     }
//   }
// }

export default async function Index() {


  // console.log(user)

  const cookieStore = cookies()

  const canInitSupabaseClient = () => {
    // This function is just for the interactive tutorial.
    // Feel free to remove it once you have Supabase connected.
    try {
      createClient(cookieStore)
      return true
    } catch (e) {
      return false
    }
  }

  const isSupabaseConnected = canInitSupabaseClient()

  return (
    <div className="flex-1 w-full flex flex-col gap-20">

      <div className="animate-in flex-1 flex flex-col gap-20 opacity-0 px-3">
        {/* <Header /> */}
        <Menulist/>
        {/* <UserList/> */}
      </div>

    <br/>
    
      <footer className="w-full border-t border-t-foreground/10 p-8 flex justify-center text-center text-xs">
        <p>
          Powered by{' '}
          <a 
            href="https://supabase.com/?utm_source=create-next-app&utm_medium=template&utm_term=nextjs"
            target="_blank"
            className="font-bold hover:underline"
            rel="noreferrer"
          >
            Supabase
          </a>
        </p>
      </footer>
    </div>
  )
}
